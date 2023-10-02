﻿
namespace MauiWallet.Views.Popups;

public partial class ConstructListDialogPopup : Popup
{
    #region Properties
    private List<object> _InitialItems { get; }

    #region Bindable Properties
    public ObservableRangeCollection<object> ReturnValueItems
    {
        get { return (ObservableRangeCollection<object>)GetValue(ReturnValueItemsProperty); }
        set { SetValue(ReturnValueItemsProperty, value); }
    }
    public List<object> AvailableItems
    {
        get { return (List<object>)GetValue(AvailableItemsProperty); }
        set { SetValue(AvailableItemsProperty, value); }
    }

    #region Bindable Properties Initialisers
    public static readonly BindableProperty ReturnValueItemsProperty = BindableProperty.Create(nameof(ReturnValueItems), typeof(ObservableRangeCollection<object>), typeof(ConstructListDialogPopup), defaultValueCreator: ReturnValueItemsDefaultValueCreator);
    public static readonly BindableProperty AvailableItemsProperty = BindableProperty.Create(nameof(AvailableItems), typeof(List<object>), typeof(ConstructListDialogPopup));
    #endregion

    #endregion

    #region Commands
    public ICommand CloseDialogCommand { get; set; }
    public ICommand CancelDialogCommand { get; set; }
    public ICommand ResetReturnValueItemsCommand { get; set; }
    public ICommand AddItemCommand { get; set; }
    public ICommand RemoveItemCommand { get; set; }
    public ICommand ClearReturnValueItemsCommand { get; set; }
    #endregion

    #endregion

    #region Constructors
    public ConstructListDialogPopup(IEnumerable AvailableItems)
        :this(new List<object>(), AvailableItems)
    {
    }
    public ConstructListDialogPopup(IEnumerable InitialItems, IEnumerable AvailableItems)
    {
        CloseDialogCommand = new Command(() => Close(new List<object>(ReturnValueItems)));
        CancelDialogCommand = new Command(CancelDialog);
        ResetReturnValueItemsCommand = new Command(ResetReturnValueItems);
        AddItemCommand = new Command<object>(AddItem);
        RemoveItemCommand = new Command<object>(RemoveItem);
        ClearReturnValueItemsCommand = new Command(ClearReturnValueItems);

        InitializeComponent();

        _InitialItems = InitialItems.Cast<object>().ToList();
        this.AvailableItems = AvailableItems.Cast<object>().ToList();

        ResetReturnValueItems();
        ResultWhenUserTapsOutsideOfPopup = _InitialItems;
    }
    #endregion

    #region Methods
    public void CancelDialog()
    {
        Close(_InitialItems);
    }
    public void ResetReturnValueItems()
    {
        ReturnValueItems.ReplaceRange(_InitialItems);
    }
    public void AddItem(object Item)
    {
        if (Item != null)
        {
            ReturnValueItems.Add(Item);
        }
    }
    public void RemoveItem(object Item)
    {
        if (Item != null)
        {
            ReturnValueItems.Remove(Item);
        }
    }
    public void ClearReturnValueItems()
    {
        ReturnValueItems.Clear();
    }

    #region Bindable Properties Methods
    private static object ReturnValueItemsDefaultValueCreator(BindableObject bindable)
    {
        return new ObservableRangeCollection<object>();
    }
    #endregion

    #endregion
}