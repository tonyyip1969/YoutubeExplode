namespace YoutubeExplode.Videos.ClosedCaptions
{
    /// <summary>
    /// YouTube closed caption track metadata.
    /// </summary>
    public class ClosedCaptionTrackInfo
    {
        /// <summary>
        /// URL of the associated track.
        /// </summary>
        public string Url { get; }

        /// <summary>
        /// Language of the associated track.
        /// </summary>
        public Language Language { get; }

        /// <summary>
        /// Whether the associated track was automatically generated.
        /// </summary>
        public bool IsAutoGenerated { get; }

        /// <summary>
        /// Initializes an instance of <see cref="ClosedCaptionTrackInfo"/>.
        /// </summary>
        public ClosedCaptionTrackInfo(string url, Language language, bool isAutoGenerated)
        {
            Url = url;
            Language = language;
            IsAutoGenerated = isAutoGenerated;
        }

        /// <inheritdoc />
        public override string ToString() => $"CC Track ({Language})";
    }
}