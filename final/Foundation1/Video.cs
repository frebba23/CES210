using System;
using System.Collections.Generic;

//Video class to track the title, author, and length (in seconds) of the video
public class Video
{
    public string title { get; set; }
    public string author { get; set; }
    public int length { get; set; }
    public List<Comment> comments { get; set; }

    //Method to return the number of comments
    public int GetNumberOfComments()
    {
        return comments.Count;
    }
}