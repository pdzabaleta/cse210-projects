using System;
public class Event
{
 private string _title;
 private string _description;
 private string _date;
 private string _time;
 private Address _address;
 public Event(string title, string description, string date, string time, Address address)
 {
    _title = title;
    _description = description; 
    _date = date;
    _time = time;
    _address = address;
    
 }
 public virtual string EventType()
{
    return "Event"; 
}
public virtual string GetDetails()
{
    return string.Empty;
}
 public string GetStandardDetails()
 {
    return$"{_title} - {_description}\n{_date} @ {_time}\n{_address.GetFullAddress()}";
 }
 public string GetFullDetails()
 {
    return $"\nType: {EventType()}\n{GetStandardDetails()}{GetDetails()}";
 }
 public string GetShortDescription()
 {
    return $"\n{EventType()} - {_title} - {_date}\n================================";
 }
}