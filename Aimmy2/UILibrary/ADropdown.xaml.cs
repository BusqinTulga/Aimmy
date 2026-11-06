using Aimmy2.Class;
using Other;
using System.Windows.Controls;
using UserControl = System.Windows.Controls.UserControl;

namespace UILibrary
{
    /// <summary>
    /// Interaction logic for ADropdown.xaml
    /// </summary>
    public partial class ADropdown : UserControl
    {
        private string main_dictionary_path { get; set; }

        /// <summary>用于配置字典的英文键名，不受界面翻译影响。</summary>
        public string DictionaryKey => main_dictionary_path;

        public ADropdown(string title, string dictionary_path, string? tooltip = null)
        {
            InitializeComponent();
            DropdownTitle.Content = Loc.T(title);
            main_dictionary_path = dictionary_path;

            if (!string.IsNullOrEmpty(tooltip))
            {
                var tt = new System.Windows.Controls.ToolTip { Content = Loc.T(tooltip) };
                if (TryFindResource("Tooltip") is System.Windows.Style style)
                    tt.Style = style;
                ToolTip = tt;
            }
        }

        private void DropdownBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // 显示内容是中文，Tag 中保存原始英文值，确保配置兼容
            var selectedItem = DropdownBox.SelectedItem as ComboBoxItem;
            var selectedItemContent = selectedItem?.Tag?.ToString() ?? selectedItem?.Content?.ToString();
            if (selectedItemContent != null)
            {
                Dictionary.dropdownState[main_dictionary_path] = selectedItemContent;
            }
        }
    }
}