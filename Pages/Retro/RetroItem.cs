public class RetroItem
{
    public int Id { get; set; }
    public string Text { get; set; }
    public bool IsLiked { get; set; }
    public bool IsDisliked { get; set; }
    public bool IsStarred { get; set; }
    public string Author {get; set; }
    public string LikeImgSrc => IsLiked ? "../Icons/thumbs-up-filled.svg" : "../Icons/thumbs-up.svg";
    public string DislikeImgSrc => IsDisliked ? "../Icons/thumbs-down-filled.svg" : "../Icons/thumbs-down.svg";
    public string StarImgSrc => IsStarred ? "../Icons/star-filled.svg" : "../Icons/star.svg";

}
