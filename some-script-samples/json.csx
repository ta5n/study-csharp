

#r "nuget: Newtonsoft.Json, 13.0.1"

using System;
using Newtonsoft.Json;

class MyDateAndTime{
    public String Date {get;set;}
    public String Time {get;set;}
}

// var dateAndTime = new MyDateAndTime(){
//     Date= DateTime.Now.ToString("yyyy-MM-dd"),
//     Time= DateTime.Now.ToString("HH:mm:ss")
// };

// Console.WriteLine(JsonConvert.SerializeObject(dateAndTime, Formatting.Indented));
