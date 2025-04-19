namespace QBSDK.Data;

public class QBVersion(int majorVersion = 13, int minorVersion = 0, QBEdition qbEdition = QBEdition.ALL)
{
    public int MajorVersion { get; set; } = majorVersion;
    public int MinorVersion { get; set; } = minorVersion;
    public QBEdition QBEdition { get; set; } = qbEdition;

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
