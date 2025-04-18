namespace QBSDK.Data;

[Flags]
public enum QBEdition
{
    US = 1 << 0,
    CA = 1 << 1,
    UK = 1 << 2,
    ALL = US | CA | UK
}
