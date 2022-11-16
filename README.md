# RealMD5Hash-for-Unity
In many cases MD5 hashing of a string value does not match in C# and PHP.
For example the string "123" give these different results:

```
PHP: 202cb962ac59075b964b07152d234b70
C# : 62b92c2059ac5b07964b07152d234b70
```

This class gives back the same result in both PHP and C#.

## Usage

```
string hash = RealMD5Hash.MD5Php("stringtohash").ToString();
Debug.Log(hash);
```
