namespace TesserNet
{
    /// <summary>
    /// Represents the output format to use when returning text from Tesseract.
    /// </summary>
    public enum TesseractTextOutputFormat
    {
        /// <summary>
        /// Return as plain text
        /// </summary>
        PlainText = 0,

        /// <summary>
        /// Return as hORC formatted HTML
        /// </summary>
        HOCR = 1,

        /// <summary>
        /// Return as Alto text
        /// </summary>
        Alto = 2,

        /// <summary>
        /// Return as TSV text
        /// </summary>
        Tsv = 3,

        /// <summary>
        /// Return as box text
        /// </summary>
        BoxText = 4,

        /// <summary>
        /// Return as LSTMBox text
        /// </summary>
        LTSMBoxText = 5,

        /// <summary>
        /// Return as WordStrBox text.
        /// </summary>
        WordStrBoxText = 6,

        /// <summary>
        /// Return as UNLV text
        /// </summary>
        UNLVText = 7,
    }
}
