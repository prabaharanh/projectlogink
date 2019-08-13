using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace projectlogin
{
  public class Security
  {


      public static string GetHash512(string password, string salt)
      {
        byte[] passwordByte = ASCIIEncoding.ASCII.GetBytes(password + salt + "SM");

        HashAlgorithm algorithm = SHA512.Create();
        byte[] hashPassword = algorithm.ComputeHash(passwordByte);
        return Convert.ToBase64String(hashPassword);
      }
    
  }
}
