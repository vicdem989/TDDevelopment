namespace converter;

class Converter {
    public static double Convert(double numberToConvert, string format) {

        /// Find a solution to figure out if format is mm, cm, m
        /// Having converter class
        /// mm : converter
        /// cm : converter
        /// m : converter
        

        /// Fix magic double for format values



        if(format == "mm") 
            return Math.Round(numberToConvert * 25.4, 2);
        else if (format == "cm") 
            return Math.Round(numberToConvert * 2.54, 2);
        else if (format == "m") 
            return Math.Round(numberToConvert * 0.0254, 2);

        return 1;
    }
}

class ConvertToMM : Converter {
    double Convert() {
        return 1;
    }   
}