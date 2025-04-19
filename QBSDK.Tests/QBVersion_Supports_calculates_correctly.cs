namespace QBSDK.Tests;

public class QBVersion_Supports_calculates_correctly
{
    [Fact]
    public void QBVersionSupportsLowerMajorVersion()
    {
        QBVersion sourceVersion = new();
        QBVersion lowerMajorVersion = new(8, 0, QBEdition.ALL);

        Assert.True(sourceVersion.Supports(lowerMajorVersion));
    }

    [Fact]
    public void QBVersionDoesNotSupportHigherMajorVersion()
    {
        QBVersion sourceVersion = new(10, 0, QBEdition.ALL);
        QBVersion higherMajorVersion = new();

        Assert.False(sourceVersion.Supports(higherMajorVersion));
    }

    [Fact]
    public void QBVersionSupportsLowerMinorVersion()
    {
        QBVersion sourceVersion = new(12, 5, QBEdition.ALL);
        QBVersion lowerMinorVersion = new(12, 0, QBEdition.ALL);

        Assert.True(sourceVersion.Supports(lowerMinorVersion));
    }

    [Fact]
    public void QBVersionDoesNotSupportHigherMinorVersion()
    {
        QBVersion sourceVersion = new();
        QBVersion higherMinorVersion = new(13, 5, QBEdition.ALL);

        Assert.False(sourceVersion.Supports(higherMinorVersion));
    }

    [Fact]
    public void QBVersionSupportSingleEdition()
    {
        QBVersion sourceVersion = new();
        QBVersion singleEditionVersion = new QBVersion(13, 0, QBEdition.CA);

        Assert.True(sourceVersion.Supports(singleEditionVersion));
    }

    [Fact]
    public void QBVersionSupportsMultipleEditions()
    {
        QBVersion sourceVersion = new();
        QBVersion multipleEditionVersion = new QBVersion(13, 0, QBEdition.CA | QBEdition.UK);

        Assert.True(sourceVersion.Supports(multipleEditionVersion));
    }

    [Fact]
    public void QBVersionDoesNotSupportSingleEdition()
    {
        QBVersion sourceVersion = new(13, 0, QBEdition.US);
        QBVersion singleEditionVersion = new QBVersion(13, 0, QBEdition.CA);

        Assert.False(sourceVersion.Supports(singleEditionVersion));
    }

    [Fact]
    public void QBVersionDoesNotSupportMultipleEditions()
    {
        QBVersion sourceVersion = new(13, 0, QBEdition.US);
        QBVersion multipleEditionVersion = new QBVersion(13, 0, QBEdition.CA | QBEdition.UK);

        Assert.False(sourceVersion.Supports(multipleEditionVersion));
    }
}
