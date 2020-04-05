namespace WordUnscrambler
{
    class Constants
    {
        public const string OptionsOnHowToEnterScrambledWords = "Please enter the option - F for file and M for Manual";
        public const string OptionsOnContinuingTheProgram = "Do you want to continue? Y/N";

        public const string EnterScrambledWordsViaFile = "Enter scrambled words full path of file name: ";
        public const string EnterScrambledWordsManually = "Enter scrambled word(s) manually (separated with commas if multiple): ";
        public const string EnterScrambledWordsOptionNotRecognized = "Option was not recognised!";

        public const string ErrorScrambledWordsCannotBeLoaded = "Scrambled words were not loaded because there was an error.";
        public const string ErrorProgramWillBeTerminated = "The Program will be terminated.";

        public const string MatchFound = "MATCH FOUND FOR {0}: {1}";
        public const string NoMatchFound = "NO MATCHED HAVE BEEN FOUND";

        public const string Yes = "Y";
        public const string No = "N";
        public const string File = "F";
        public const string Manual = "M";

        public const string wordListFileName = "wordlist.txt";
    }
}
