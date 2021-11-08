using System;

namespace MyPhotoStudio.Models
{
    public sealed class PhotoOptions
    {
        public OperationType Type               { get; set; } = OperationType.OfficialPhotos;
        public PhotoPaper    PhotoPaper         { get; set; } = PhotoPaper.None;
        public PhotoSize     PhotoSize          { get; set; } = PhotoSize.R5;

        public bool          UsePhotoPaper      { get; set; } = true;
        public bool          SizeAndTrimPhotos  { get; set; } = false;
        public bool          CreateFrames       { get; set; } = false;

        public int           NumberOfPictures   { get; set; } = 0;
    }
}
