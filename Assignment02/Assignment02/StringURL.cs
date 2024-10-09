namespace Assignment02;

public class StringURL
{
    public void StringURL1(String url)
    {
        string protocol = null;
        string server = null;
        string resource = null;
        
        int protocolEndIndex = url.IndexOf("://");
        if (protocolEndIndex != -1)
        {
            protocol = url.Substring(0, protocolEndIndex);
            url = url.Substring(protocolEndIndex + 3);
        }
        
        int serverEndIndex = url.IndexOf('/');
        if (serverEndIndex != -1)
        {
            server = url.Substring(0, serverEndIndex);
            resource = url.Substring(serverEndIndex + 1);
        }
        else
        {
            server = url;
        }
        Console.WriteLine("Parsed URL parts:");
        Console.WriteLine($"Protocol: {protocol}");
        Console.WriteLine($"Server: {server}");
        Console.WriteLine($"Resource: {resource}");
        

    }
}