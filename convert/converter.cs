namespace converter;

class Converter {
    public static double Convert(double numberToConvert, string format) {
        double inchesToMMRatio = 25.4;
        double inchesToCMRatio = 2.54;
        double inchesToMRatio = 0.0254;

        if(format == "mm") 
            return Math.Round(numberToConvert * inchesToMMRatio, 2);
        else if (format == "cm") 
            return Math.Round(numberToConvert * inchesToCMRatio, 2);
        else if (format == "m") 
            return Math.Round(numberToConvert * inchesToMRatio, 2);

        return 1;
    }
}