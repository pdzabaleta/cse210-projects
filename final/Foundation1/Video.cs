using System;

public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments = new List<Comment>(); 
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = length;
        
    }
    public void AddComment(Comment comment)
        {  
            _comments.Add(comment);
        }
    public int GetNumberOfComments()
        {
            return _comments.Count;
        }
    public List<Comment> GetComments()
        {
            return _comments;
        }
    public string GetTitle()
    {
        return _title;
    }
    
    public string GetAuthor()
    {
        return _author;
    }
    
    public float GetLengthInSeconds()
    {
        return _lengthInSeconds;
    }
}
