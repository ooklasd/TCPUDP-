using System;
using System.Text;


class js
{
    public string send(byte[] buffer)
    {
        //×ª»¯Îªutf8
        Encoding utf8 = Encoding.GetEncoding("UTF-8");
        Encoding gb2312 = Encoding.GetEncoding("GB2312");
        var gb = Encoding.Convert(gb2312,utf8, buffer);
        string result = utf8.GetString(gb, 0, gb.Length);

        return "$" + result + "#";
    }
}