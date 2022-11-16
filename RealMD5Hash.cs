using System.Security.Cryptography;
using System.Text;

public static class RealMD5Hash
{
    public static string MD5Php(string input)
    {
        // Input form to hash
        MD5 h = MD5.Create();
        byte[] data = h.ComputeHash(Encoding.Default.GetBytes(input));

        // Create the correct MD5 Hash string representation
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < data.Length; ++i)
        {
            sb.Append(data[i].ToString("x2"));
        }
        return sb.ToString();
    }
}
