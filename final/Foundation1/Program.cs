public class Program
{
    public static void Main(string[] args)
    {
        //Creating 4 videos
        Video video1 = new Video
        {
            title = "Video 1",
            author = "John Dhiri",
            length = 120
        };
        Video video2 = new Video
        {
            title = "Video 2",
            author = "Fiona Cook",
            length = 180
        };
        Video video3 = new Video
        {
            title = "Video 3",
            author = "Frebba Sounz",
            length = 240
        };
        Video video4 = new Video
        {
            title = "Video 4",
            author = "Jane Summers",
            length = 300
        };

        //Setting the appropriate values
        video1.comments = new List<Comment>
        {
            new Comment { name = "User1", text = "Nice video!" },
            new Comment { name = "User2", text = "Interesting video!" },
            new Comment { name = "User3", text = "Awesome video!" },
            new Comment { name = "User4", text = "Love this video!" }
        };
        video2.comments = new List<Comment>
        {
            new Comment { name = "User5", text = "Very informative!" },
            new Comment { name = "User6", text = "Very helpful!" },
            new Comment { name = "User7", text = "Very interesting!" },
            new Comment { name = "User8", text = "Very nice!" }
        };
        video3.comments = new List<Comment>
        {
            new Comment { name = "User9", text = "Fantastic video!" },
            new Comment { name = "User10", text = "Excellent video!" },
            new Comment { name = "User11", text = "Good video!" },
            new Comment { name = "User12", text = "Enjoyable video!" }
        };
        video4.comments = new List<Comment>
        {
            new Comment { name = "User13", text = "Great work!" },
            new Comment { name = "User14", text = "Impressive!" },
            new Comment { name = "User15", text = "Amazing!" },
            new Comment { name = "User16", text = "Brilliant!" }
        };

        //Put each of these videos in a list
        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3,
            video4
        };

        //Iterate through the list of videos and output the title, author, length, and the number of comments for each video.
        foreach (var video in videos)
        {
            Console.WriteLine("Title: " + video.title);
            Console.WriteLine("Author: " + video.author);
            Console.WriteLine("Length: " + video.length + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());
            Console.WriteLine();
        }
    }
}