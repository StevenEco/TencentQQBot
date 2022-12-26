using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TencentQQBot.Sdk;
public static class ExtensionFunc
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="isUpper"></param>
    /// <param name="args"></param>
    /// <returns></returns>
    public static string ToParameter(bool isUpper = false,params (string,string)[] args)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < args.Length; i++)
        {
            if (i == 0)
                sb.Append("?");
            if (isUpper)
                sb.Append(FirstToUpper(args[i].Item1));
            else
                sb.Append(args[i].Item1);
            sb.Append("=" + args[i].Item2 + "&");
        }
        sb.Remove(sb.Length - 1, 1);
        return sb.ToString();
    }
    
    private static string FirstToUpper(string arg)
    {
        string result = string.Empty;
        if(arg[0]>=97 && arg[0]<=122)
        {
            char first = (char)(arg[0] - 32);
            result = first+arg.Substring(1);
        }
        else
        {
            throw new ArgumentOutOfRangeException();
        }
        return result;
    }
}