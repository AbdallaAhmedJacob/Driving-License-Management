using System.Drawing;
using System.Windows.Forms;

namespace DVLD.WinForms.UI
{
    public static class clsTheme
    {
        // =========================================================
        // Colors
        // =========================================================

        // Main Application Colors
        public static readonly Color Primary =
            Color.FromArgb(37, 99, 235);          // #2563EB

        public static readonly Color PrimaryHover =
            Color.FromArgb(29, 78, 216);          // #1D4ED8

        public static readonly Color PrimaryLight =
            Color.FromArgb(239, 246, 255);        // #EFF6FF


        // Background & Surface
        public static readonly Color Background =
            Color.FromArgb(245, 247, 250);        // #F5F7FA

        public static readonly Color Surface =
            Color.White;

        public static readonly Color Sidebar =
            Color.FromArgb(23, 32, 51);           // #172033


        // Text Colors
        public static readonly Color TextPrimary =
            Color.FromArgb(23, 32, 51);           // #172033

        public static readonly Color TextSecondary =
            Color.FromArgb(100, 116, 139);        // #64748B

        public static readonly Color TextDisabled =
            Color.FromArgb(148, 163, 184);        // #94A3B8

        public static readonly Color TextWhite =
            Color.White;


        // Border & Divider
        public static readonly Color Border =
            Color.FromArgb(226, 232, 240);        // #E2E8F0

        public static readonly Color Divider =
            Color.FromArgb(241, 245, 249);        // #F1F5F9


        // Status Colors
        public static readonly Color Success =
            Color.FromArgb(22, 163, 74);          // #16A34A

        public static readonly Color SuccessLight =
            Color.FromArgb(240, 253, 244);        // #F0FDF4


        public static readonly Color Warning =
            Color.FromArgb(245, 158, 11);         // #F59E0B

        public static readonly Color WarningLight =
            Color.FromArgb(255, 251, 235);        // #FFFBEB


        public static readonly Color Danger =
            Color.FromArgb(220, 38, 38);           // #DC2626

        public static readonly Color DangerLight =
            Color.FromArgb(254, 242, 242);        // #FEF2F2


        public static readonly Color Info =
            Color.FromArgb(14, 165, 233);         // #0EA5E9

        public static readonly Color InfoLight =
            Color.FromArgb(240, 249, 255);        // #F0F9FF

        // Menu Strip
        public static readonly Color MenuHoverBackColor =
            Color.FromArgb(37, 50, 75);

        public static readonly Color MenuDropDownBackColor =
            Color.FromArgb(23, 32, 51);

        public static readonly Color MenuDropDownBorderColor =
            Color.FromArgb(51, 65, 85);

        // =========================================================
        // Fonts
        // =========================================================

        private const string FontFamily = "Segoe UI";

        public static readonly Font FontRegular =
            new Font(FontFamily, 9F, FontStyle.Regular);

        public static readonly Font FontMedium =
            new Font(FontFamily, 9F, FontStyle.Bold);

        public static readonly Font FontSmall =
            new Font(FontFamily, 8F, FontStyle.Regular);

        public static readonly Font FontSmallMedium =
            new Font(FontFamily, 8F, FontStyle.Bold);

        public static readonly Font FontLarge =
            new Font(FontFamily, 11F, FontStyle.Regular);

        public static readonly Font FontLargeMedium =
            new Font(FontFamily, 11F, FontStyle.Bold);

        public static readonly Font FontTitle =
            new Font(FontFamily, 16F, FontStyle.Bold);

        public static readonly Font FontPageTitle =
            new Font(FontFamily, 20F, FontStyle.Bold);


        // =========================================================
        // Sizes
        // =========================================================

        public const int BorderRadius = 8;

        public const int ControlHeight = 36;

        public const int ButtonHeight = 36;

        public const int SidebarWidth = 230;

        public const int HeaderHeight = 64;

        public const int DefaultPadding = 20;

        public const int SmallPadding = 10;

        public const int LargePadding = 30;


        // =========================================================
        // DataGridView
        // =========================================================

        public static readonly Color GridHeaderBackColor =
            Color.FromArgb(248, 250, 252);        // #F8FAFC

        public static readonly Color GridHeaderForeColor =
            TextSecondary;

        public static readonly Color GridRowBackColor =
            Surface;

        public static readonly Color GridAlternateRowBackColor =
            Color.FromArgb(248, 250, 252);        // #F8FAFC

        public static readonly Color GridSelectionBackColor =
            PrimaryLight;

        public static readonly Color GridSelectionForeColor =
            TextPrimary;


        // =========================================================
        // Form Settings
        // =========================================================

        public const FormBorderStyle DefaultFormBorderStyle =
            FormBorderStyle.FixedSingle;

        public const FormStartPosition DefaultStartPosition =
            FormStartPosition.CenterScreen;


        // =========================================================
        // Other UI Settings
        // =========================================================

        public const int AnimationDuration = 150;
    }
}