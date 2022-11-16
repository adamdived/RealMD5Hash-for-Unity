# RealMD5Hash-for-Unity
In many cases MD5 hashing of a string value does not match in C# and PHP. This script gives back the same result in both PHP and C#.

###### Usage

`private void Start()
{
    string hash = RealMD5Hash.MD5Php("iononvogliostareinquestomondo2022").ToString();
    Debug.Log(hash);
}`
