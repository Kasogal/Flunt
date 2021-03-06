﻿namespace Flunt.Localization
{
    public static class FluntRegexPatterns
    {
        public static string EmailRegexPattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
        public static string UrlRegexPattern = @"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$";
        public static string OnlyNumbersPattern = @"[^0-9]+";
        public static string OnlyLettersAndNumbersPatter = @"[A-Za-z0-9_-]";
        public static string PassportRegexPattern = @"^(?!^0+$)[a-zA-Z0-9]{3,20}$";
    }
}
