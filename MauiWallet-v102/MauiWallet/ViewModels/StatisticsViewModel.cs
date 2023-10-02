using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using LiveChartsCore.SkiaSharpView.Painting.Effects;
using LiveChartsCore.Measure;

using MauiWallet.Controls.Charts;
using LiveChartsCore.Kernel.Sketches;

namespace MauiWallet.ViewModels;
public partial class StatisticsViewModel : ObservableObject
{
    #region Fiels & Properties
    [ObservableProperty]
    private double _totalIncome;

    [ObservableProperty]
    private double _totalExpense;

    private string[] days;

    private string[] weeks;

    private string[] months;

    private string[] section;

    [ObservableProperty]
    private ObservableCollection<TransactionData> _weekListItems;

    [ObservableProperty]
    private ObservableCollection<ISeries> _weekChart;

    [ObservableProperty]
    private ObservableCollection<TransactionData> _monthListItems;

    [ObservableProperty]
    private ObservableCollection<ISeries> _monthChart;

    [ObservableProperty]
    private ObservableCollection<TransactionData> _yearListItems;

    [ObservableProperty]
    private ObservableCollection<ISeries> _yearChart;

    [ObservableProperty]
    private ObservableCollection<TransactionData> _transactionLists;

    public ObservableCollection<ISeries> ChartData { get; private set; }

    public ObservableCollection<TransactionData> DataSource { get; private set; }


    private int _selectedIndex;
    public int SelectedIndex
    {
        get
        {
            return _selectedIndex;
        }
        set
        {
            _selectedIndex = value;
            UpdateListViewData();
        }
    }

    #endregion Fiels & Properties
    public StatisticsViewModel()
    {
        WeekData();
        MonthData();
        YearData();
        ChartData = new ObservableCollection<ISeries>();
        DataSource = new ObservableCollection<TransactionData>()
        {
            new TransactionData() { Duration = "Week" },
            new TransactionData() { Duration = "Month" },
            new TransactionData() { Duration = "Year" },
        };

        TransactionLists = WeekListItems;
        ChartData = WeekChart;

        UpdateIncomeExpenseData();
    }

    private void WeekData()
    {
        WeekListItems = new ObservableCollection<TransactionData>()
        {
            new TransactionData
            {
                ImageIcon = MauiKitIcons.Food,
                IconColor = Color.FromArgb("#3e5aff"),
                Title = "Food for lunch",
                Date = "3:05 PM - Aug 22, 2022",
                Amount = 12.50,
                IsCredited = false
            },
            new TransactionData
            {
                ImageIcon = MauiKitIcons.Camera,
                IconColor = Color.FromArgb("#7644ad"),
                Title = "Netflix Subscription",
                Date = "7:00 AM - Mar 22, 2023",
                Amount = 719.99,
                IsCredited = false
            },
            new TransactionData
            {
                ImageIcon = MauiKitIcons.Receipt,
                IconColor = Color.FromArgb("#d54381"),
                Title = "Salary",
                Date = "3:05 PM - Aug 22, 2022",
                Amount = 4689.89,
                IsCredited = true
            },
            new TransactionData
            {
                ImageIcon = MauiKitIcons.Airballoon,
                IconColor = Color.FromArgb("#af4aff"),
                Title = "AirBNB Royalty",
                Date = "3:05 PM - Aug 22, 2022",
                Amount = 125.50,
                IsCredited = false
            },
        };

        WeekChart = new ObservableCollection<ISeries>
        {
            new PieSeries<int> { Name = "Salary", Values = new List<int> { 2 }, InnerRadius = 150 },
            new PieSeries<int> { Name = "Food & Drink", Values = new List<int> { 4 }, InnerRadius = 150 },
            new PieSeries<int> { Name = "E-Wallet", Values = new List<int> { 1 }, InnerRadius = 150 },
            new PieSeries<int> { Name = "Internet", Values = new List<int> { 4 }, InnerRadius = 150 },
            new PieSeries<int> { Name = "Shopping", Values = new List<int> { 3 }, InnerRadius = 150 }
        };
    }

    private void MonthData()
    {
        MonthListItems = new ObservableCollection<TransactionData>()
        {
            new TransactionData
            {
                ImageIcon = MauiKitIcons.Camera,
                IconColor = Color.FromArgb("#7644ad"),
                Title = "Netflix Subscription",
                Date = "7:00 AM - Mar 22, 2023",
                Amount = 719.99,
                IsCredited = false
            },
            new TransactionData
            {
                ImageIcon = MauiKitIcons.Receipt,
                IconColor = Color.FromArgb("#d54381"),
                Title = "Salary",
                Date = "3:05 PM - Aug 22, 2022",
                Amount = 4689.89,
                IsCredited = true
            },
            new TransactionData
            {
                ImageIcon = MauiKitIcons.Food,
                IconColor = Color.FromArgb("#3e5aff"),
                Title = "Food for lunch",
                Date = "3:05 PM - Aug 22, 2022",
                Amount = 32.50,
                IsCredited = false
            },
            new TransactionData
            {
                ImageIcon = MauiKitIcons.Airballoon,
                IconColor = Color.FromArgb("#af4aff"),
                Title = "AirBNB Royalty",
                Date = "3:05 PM - Aug 22, 2022",
                Amount = 185.50,
                IsCredited = false
            },
            new TransactionData
            {
                ImageIcon = MauiKitIcons.Camera,
                IconColor = Color.FromArgb("#7644ad"),
                Title = "Arthur Kim",
                Date = "7:00 AM - Mar 22, 2023",
                Amount = 65,
                IsCredited = false
            },
            new TransactionData
            {
                ImageIcon = MauiKitIcons.Receipt,
                IconColor = Color.FromArgb("#d54381"),
                Title = "Nell Sanchez",
                Date = "3:05 PM - Aug 22, 2022",
                Amount = 565,
                IsCredited = true
            },
            new TransactionData
            {
                ImageIcon = MauiKitIcons.Food,
                IconColor = Color.FromArgb("#3e5aff"),
                Title = "Amelia Coleman",
                Date = "3:05 PM - Aug 22, 2022",
                Amount = 70.50,
                IsCredited = false
            },
            new TransactionData
            {
                ImageIcon = MauiKitIcons.Airballoon,
                IconColor = Color.FromArgb("#af4aff"),
                Title = "Credit Card Bill",
                Date = "3:05 PM - Aug 22, 2022",
                Amount = 30.50,
                IsCredited = false
            },
        };

        MonthChart = new ObservableCollection<ISeries>
        {
            new PieSeries<int> { Name = "Salary", Values = new List<int> { 22 }, InnerRadius = 150 },
            new PieSeries<int> { Name = "Food & Drink", Values = new List<int> { 10 }, InnerRadius = 150 },
            new PieSeries<int> { Name = "E-Wallet", Values = new List<int> { 4 }, InnerRadius = 150 },
            new PieSeries<int> { Name = "Internet", Values = new List<int> { 25 }, InnerRadius = 150 },
            new PieSeries<int> { Name = "Shopping", Values = new List<int> { 35 }, InnerRadius = 150 }
        };
    }

    private void YearData()
    {
        YearListItems = new ObservableCollection<TransactionData>()
        {
            new TransactionData
            {
                ImageIcon = MauiKitIcons.Receipt,
                IconColor = Color.FromArgb("#d54381"),
                Title = "Salary",
                Date = "3:05 PM - Aug 22, 2022",
                Amount = 4789.89,
                IsCredited = true
            },
            new TransactionData
            {
                ImageIcon = MauiKitIcons.Airballoon,
                IconColor = Color.FromArgb("#af4aff"),
                Title = "AirBNB Royalty",
                Date = "3:05 PM - Aug 22, 2022",
                Amount = 135.50,
                IsCredited = false
            },
            new TransactionData
            {
                ImageIcon = MauiKitIcons.Food,
                IconColor = Color.FromArgb("#3e5aff"),
                Title = "Food for lunch",
                Date = "3:05 PM - Aug 22, 2022",
                Amount = 22.50,
                IsCredited = false
            },
            new TransactionData
            {
                ImageIcon = MauiKitIcons.Camera,
                IconColor = Color.FromArgb("#7644ad"),
                Title = "Netflix Subscription",
                Date = "7:00 AM - Mar 22, 2023",
                Amount = 519.99,
                IsCredited = false
            },
            new TransactionData
            {
                ImageIcon = MauiKitIcons.Camera,
                IconColor = Color.FromArgb("#7644ad"),
                Title = "Arthur Kim",
                Date = "7:00 AM - Mar 22, 2023",
                Amount = 65,
                IsCredited = false
            },
            new TransactionData
            {
                ImageIcon = MauiKitIcons.Receipt,
                IconColor = Color.FromArgb("#d54381"),
                Title = "Nell Sanchez",
                Date = "3:05 PM - Aug 22, 2022",
                Amount = 350,
                IsCredited = true
            },
            new TransactionData
            {
                ImageIcon = MauiKitIcons.Food,
                IconColor = Color.FromArgb("#3e5aff"),
                Title = "Amelia Coleman",
                Date = "3:05 PM - Aug 22, 2022",
                Amount = 70.50,
                IsCredited = false
            },
            new TransactionData
            {
                ImageIcon = MauiKitIcons.Airballoon,
                IconColor = Color.FromArgb("#af4aff"),
                Title = "Credit Card Bill",
                Date = "3:05 PM - Aug 22, 2022",
                Amount = 30.50,
                IsCredited = false
            },
            new TransactionData
            {
                ImageIcon = MauiKitIcons.Camera,
                IconColor = Color.FromArgb("#7644ad"),
                Title = "Refund",
                Date = "7:00 AM - Mar 22, 2023",
                Amount = 35,
                IsCredited = false
            },
            new TransactionData
            {
                ImageIcon = MauiKitIcons.Receipt,
                IconColor = Color.FromArgb("#d54381"),
                Title = "Nell Sanchez",
                Date = "3:05 PM - Aug 22, 2022",
                Amount = 650,
                IsCredited = true
            },
            new TransactionData
            {
                ImageIcon = MauiKitIcons.Food,
                IconColor = Color.FromArgb("#3e5aff"),
                Title = "Chase Blair",
                Date = "3:05 PM - Aug 22, 2022",
                Amount = 20.50,
                IsCredited = false
            },
            new TransactionData
            {
                ImageIcon = MauiKitIcons.Airballoon,
                IconColor = Color.FromArgb("#af4aff"),
                Title = "Credit Card Bill",
                Date = "3:05 PM - Aug 22, 2022",
                Amount = 80.50,
                IsCredited = false
            },
        };

        YearChart = new ObservableCollection<ISeries>
        {
            new PieSeries<int> { Name = "Salary", Values = new List<int> { 230 }, InnerRadius = 150 },
            new PieSeries<int> { Name = "Food & Drink", Values = new List<int> { 130 }, InnerRadius = 150 },
            new PieSeries<int> { Name = "E-Wallet", Values = new List<int> { 70 }, InnerRadius = 150 },
            new PieSeries<int> { Name = "Internet", Values = new List<int> { 350 }, InnerRadius = 150 },
            new PieSeries<int> { Name = "Shopping", Values = new List<int> { 150 }, InnerRadius = 150 }
        };
    }

    public ISeries[] LineSeries { get; set; } =
    {
        new LineSeries<int>
        {
            Values = new int[] { 4, 4, 7, 2, 8 },
            Fill = new SolidColorPaint(SKColors.Blue.WithAlpha(90)),
            //Stroke = new SolidColorPaint(SKColors.Red) { StrokeThickness = 4 },
            LineSmoothness = 1,
        },
        new LineSeries<int>
        {
            Values = new int[] { 7, 5, 3, 2, 6 },
            Fill = new SolidColorPaint(SKColors.Red.WithAlpha(90)), 
            //Stroke = new SolidColorPaint(SKColors.Blue) { StrokeThickness = 4 },
            LineSmoothness = 1,
        }
    };


    /// <summary>
    /// Method for update the listview items.
    /// </summary>
    private void UpdateListViewData()
    {
        switch (SelectedIndex)
        {
            case 0:
                TransactionLists = WeekListItems;
                ChartData = WeekChart;
                section = days;
                break;
            case 1:
                TransactionLists = MonthListItems;
                ChartData = MonthChart;
                section = weeks;
                break;
            case 2:
                TransactionLists = YearListItems;
                ChartData = YearChart;
                section = months;
                break;
            default:
                break;
        }

        UpdateIncomeExpenseData();
    }

    /// <summary>
    /// Method for update the income and expense data.
    /// </summary>
    private void UpdateIncomeExpenseData()
    {
        TotalIncome = 0;
        TotalExpense = 0;

        var incomeCollection = TransactionLists.Where(item => item.IsCredited).ToList();
        var expenseCollection = TransactionLists.Where(item => !item.IsCredited).ToList();

        for (int i = 0; i < incomeCollection.Count; i++)
        {
            TotalIncome += incomeCollection[i].Amount;
        }
        for (int i = 0; i < expenseCollection.Count; i++)
        {
            TotalExpense += expenseCollection[i].Amount;
        }
    }

    [RelayCommand]
    private async void TransactionDetail()
    {
        await Shell.Current.GoToAsync(nameof(EReceiptPage));
    }
}
