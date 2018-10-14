using System;
using System.Reflection;

public class appinfo
{


    //--StartCopyright
    public String getCopyright()
    {
        Assembly asm = Assembly.GetExecutingAssembly();
        object[] obj = asm.GetCustomAttributes(false);
        foreach (object o in obj)
        {
            if (o.GetType() ==
                typeof(AssemblyCopyrightAttribute))
            {
                AssemblyCopyrightAttribute aca =
        (AssemblyCopyrightAttribute)o;
                return aca.Copyright;
            }
        }
        return string.Empty;
    }
    //--EndCopyright

    //--StartBeschreibung
    public String getDescription()
    {
        Assembly asm = Assembly.GetExecutingAssembly();
        object[] obj = asm.GetCustomAttributes(false);
        foreach (object o in obj)
        {
            if (o.GetType() ==
                         typeof(AssemblyDescriptionAttribute))
            {
                AssemblyDescriptionAttribute aca =
        (AssemblyDescriptionAttribute)o;
                return aca.Description;
            }
        }
        return string.Empty;
    }
    //--EndBeschreibung

    //--StartFirma
    public String getCompany()
    {
        Assembly asm = Assembly.GetExecutingAssembly();
        object[] obj = asm.GetCustomAttributes(false);
        foreach (object o in obj)
        {
            if (o.GetType() ==
                typeof(AssemblyCompanyAttribute))
            {
                AssemblyCompanyAttribute aca =
        (AssemblyCompanyAttribute)o;
                return aca.Company;
            }
        }
        return string.Empty;
    }
    //--EndFirma


}
