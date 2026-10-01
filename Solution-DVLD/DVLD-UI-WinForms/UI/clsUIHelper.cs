using System.Drawing;
using System.Windows.Forms;

namespace DVLD.UI
{
    public static class clsUIHelper
    {
        // =========================================================
        // Apply Theme
        // =========================================================

        public static void ApplyTheme(Control parent)
        {
            if (parent == null)
                return;

            ApplyControlTheme(parent);

            foreach (Control control in parent.Controls)
            {
                ApplyTheme(control);
            }
        }


        // =========================================================
        // Apply Theme To Control
        // =========================================================

        private static void ApplyControlTheme(Control control)
        {
            if (control is Form)
            {
                ApplyFormTheme((Form)control);
            }
            else if (control is Panel)
            {
                ApplyPanelTheme((Panel)control);
            }
            else if (control is Button)
            {
                ApplyButtonTheme((Button)control);
            }
            else if (control is Label)
            {
                ApplyLabelTheme((Label)control);
            }
            else if (control is TextBox)
            {
                ApplyTextBoxTheme((TextBox)control);
            }
            else if (control is ComboBox)
            {
                ApplyComboBoxTheme((ComboBox)control);
            }
            else if (control is DateTimePicker)
            {
                ApplyDateTimePickerTheme((DateTimePicker)control);
            }
            else if (control is DataGridView)
            {
                ApplyDataGridViewTheme((DataGridView)control);
            }
        }


        // =========================================================
        // Form
        // =========================================================

        private static void ApplyFormTheme(Form form)
        {
            form.BackColor = clsTheme.Background;
            form.ForeColor = clsTheme.TextPrimary;
            form.Font = clsTheme.FontRegular;

            form.StartPosition = clsTheme.DefaultStartPosition;
            form.FormBorderStyle = clsTheme.DefaultFormBorderStyle;
        }


        // =========================================================
        // Panel
        // =========================================================

        private static void ApplyPanelTheme(Panel panel)
        {
            panel.BackColor = clsTheme.Surface;
            panel.ForeColor = clsTheme.TextPrimary;
        }


        // =========================================================
        // Button
        // =========================================================

        private static void ApplyButtonTheme(Button button)
        {
            button.BackColor = clsTheme.Primary;
            button.ForeColor = clsTheme.TextWhite;

            button.Font = clsTheme.FontMedium;

            button.FlatStyle = FlatStyle.Flat;

            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseOverBackColor =
                clsTheme.PrimaryHover;

            button.FlatAppearance.MouseDownBackColor =
                clsTheme.PrimaryHover;

            button.Cursor = Cursors.Hand;

            button.Height = clsTheme.ButtonHeight;
        }


        // =========================================================
        // Label
        // =========================================================

        private static void ApplyLabelTheme(Label label)
        {
            label.ForeColor = clsTheme.TextPrimary;
            label.Font = clsTheme.FontRegular;
        }


        // =========================================================
        // TextBox
        // =========================================================

        private static void ApplyTextBoxTheme(TextBox textBox)
        {
            textBox.BackColor = clsTheme.Surface;
            textBox.ForeColor = clsTheme.TextPrimary;

            textBox.Font = clsTheme.FontRegular;

            textBox.BorderStyle = BorderStyle.FixedSingle;

            textBox.Height = clsTheme.ControlHeight;
        }


        // =========================================================
        // ComboBox
        // =========================================================

        private static void ApplyComboBoxTheme(ComboBox comboBox)
        {
            comboBox.BackColor = clsTheme.Surface;
            comboBox.ForeColor = clsTheme.TextPrimary;

            comboBox.Font = clsTheme.FontRegular;

            comboBox.FlatStyle = FlatStyle.Flat;

            comboBox.Height = clsTheme.ControlHeight;
        }


        // =========================================================
        // DateTimePicker
        // =========================================================

        private static void ApplyDateTimePickerTheme(
            DateTimePicker dateTimePicker)
        {
            dateTimePicker.CalendarForeColor =
                clsTheme.TextPrimary;

            dateTimePicker.CalendarMonthBackground =
                clsTheme.Surface;

            dateTimePicker.CalendarTitleBackColor =
                clsTheme.Primary;

            dateTimePicker.CalendarTitleForeColor =
                clsTheme.TextWhite;

            dateTimePicker.Font = clsTheme.FontRegular;

            dateTimePicker.Height = clsTheme.ControlHeight;
        }


        // =========================================================
        // DataGridView
        // =========================================================

        private static void ApplyDataGridViewTheme(
            DataGridView dataGridView)
        {
            dataGridView.BackgroundColor =
                clsTheme.Surface;

            dataGridView.BorderStyle =
                BorderStyle.None;

            dataGridView.GridColor =
                clsTheme.Border;

            dataGridView.Font =
                clsTheme.FontRegular;

            dataGridView.EnableHeadersVisualStyles = false;


            // Header
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor =
                clsTheme.GridHeaderBackColor;

            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor =
                clsTheme.GridHeaderForeColor;

            dataGridView.ColumnHeadersDefaultCellStyle.Font =
                clsTheme.FontMedium;


            // Rows
            dataGridView.DefaultCellStyle.BackColor =
                clsTheme.GridRowBackColor;

            dataGridView.DefaultCellStyle.ForeColor =
                clsTheme.TextPrimary;

            dataGridView.DefaultCellStyle.SelectionBackColor =
                clsTheme.GridSelectionBackColor;

            dataGridView.DefaultCellStyle.SelectionForeColor =
                clsTheme.GridSelectionForeColor;


            // Alternate Rows
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor =
                clsTheme.GridAlternateRowBackColor;


            // General Settings
            dataGridView.RowHeadersVisible = false;

            dataGridView.AllowUserToAddRows = false;

            dataGridView.AllowUserToDeleteRows = false;

            dataGridView.AllowUserToResizeRows = false;

            dataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridView.MultiSelect = false;

            dataGridView.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.None;

            dataGridView.RowTemplate.Height = 36;

            dataGridView.ColumnHeadersHeight = 40;
        }
    }
}