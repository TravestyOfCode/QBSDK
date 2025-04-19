namespace QBSDK.Data;

public record struct QBVersion(int MajorVersion = 13, int MinorVersion = 0, QBEdition QBEdition = QBEdition.ALL)
{
    public bool Supports(QBVersion version)
    {
        if (version.MajorVersion < MajorVersion)
        {
            return QBEdition.HasFlag(version.QBEdition);
        }
        if (version.MajorVersion > MajorVersion)
        {
            return false;
        }
        return version.MinorVersion <= MinorVersion && QBEdition.HasFlag(version.QBEdition);
    }
    public bool Supports(int majorVersion) => MajorVersion >= majorVersion;
    public bool Supports(int majorVersion, int minorVersion)
    {
        if (majorVersion < MajorVersion)
        {
            return true;
        }
        return minorVersion <= MinorVersion;
    }
    public bool Supports(int majorVersion, QBEdition edition) => MajorVersion >= majorVersion && QBEdition.HasFlag(edition);
    public bool Supports(int majorVersion, int minorVersion, QBEdition edition)
    {
        if (majorVersion < MajorVersion)
        {
            return QBEdition.HasFlag(edition);
        }
        if (majorVersion > MajorVersion)
        {
            return false;
        }
        return minorVersion <= MinorVersion && QBEdition.HasFlag(edition);
    }
}
