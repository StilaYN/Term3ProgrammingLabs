namespace Lab2Classes
{
    public static class EnumToString
    {
        public static string ScannerTypeToString(ScannerType type)
        {
            switch (type)
            {
                case ScannerType.Flatbed: return "Flatbed";
                case ScannerType.Manual: return "Manual";
                case ScannerType.Planetary: return "Planetary";
                case ScannerType.Slide: return "Slide";
                case ScannerType.None: return "None";
                default: return "None";
            }
        }

        public static string PrinterTypeToString(PrinterType type)
        {
            switch (type)
            {
                case PrinterType.DotMatrix: return "DotMatrix";
                case PrinterType.Inject: return "Inject";
                case PrinterType.Laser: return "Laser";
                case PrinterType.Thermal: return "Thermal";
                case PrinterType.None: return "None";
                default: return "None";
            }
        }

    }
}