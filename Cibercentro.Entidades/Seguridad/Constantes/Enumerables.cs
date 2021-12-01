namespace Cibercentro.Entidades.Seguridad.Constantes;

public struct TipoMenu
{
    public const int HEADER = 1;
    public const int TREEVIEW = 2;
    public const int NORMAL = 3;

    public static Dictionary<int, string> LIST = new()
    {
        { 1, "HEADER" },
        { 2, "TREEVIEW" },
        { 3, "NORMAL" }
    };
}

public struct TipoEstado
{
    public const int ORDEN_TRABAJO = 1;
    public const int AVISO = 2;

    public static Dictionary<int, string> LIST = new()
    {
        { 1, "ORDEN DE TRABAJO" },
        { 2, "AVISO" }
    };
}

