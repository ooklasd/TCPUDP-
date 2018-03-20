using System;
using System.Text;
using System.IO;

class js
{
    public string recv(byte[] buffer)
    {
        if (buffer.Length <= 2) return "";
        Encoding utf8 = Encoding.GetEncoding("UTF-8");
        Encoding gb2312 = Encoding.GetEncoding("GB2312");
        var gb = Encoding.Convert(utf8,gb2312, buffer);
        string result = gb2312.GetString(gb, 0, gb.Length);
        result = result.Trim();
        if (result[0] == '$')
        {
            result = result.Substring(1, result.IndexOf('#')-1);
        }
        string html = File.ReadAllText("html\\json.html");
        html = html.Replace("absPath/", AppDomain.CurrentDomain.BaseDirectory);
        html = html.Replace("jsonContain", result);


        //������ҳ��ˢ�µ��ؼ�
        //ˢ�µ�ĳ����ʱ�ļ�            
        var tempFilehtml = AppDomain.CurrentDomain.BaseDirectory + @"html\index.html";

        File.WriteAllText(tempFilehtml, html);
        //����ʱ�ļ�
        System.Diagnostics.Process.Start(tempFilehtml);

        return "";
    }
}