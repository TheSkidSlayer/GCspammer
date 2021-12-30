using System;
using System.Net;
using Newtonsoft.Json;

class Program {
  public static void Main (string[] args) {
    Console.Write("Token? ");
    string token = Console.ReadLine();

    HttpWebRequest req = WebRequest.CreateHttp("https://discord.com/api/v9/users/@me/channels");
    req.Method = "POST";
    req.Headers.Add("Authorization", token);

    var rec = 

    var resStr = req.GetRequestStream();
    byte[] body = Encoding.UTF8.GetBytes("");
  }
}