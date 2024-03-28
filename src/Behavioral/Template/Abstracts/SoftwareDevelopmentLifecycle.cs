namespace Template.Abstracts;

public abstract class SoftwareDevelopmentLifecycle
{
    public void DevelopSoftware()
    {
        Analysis();
        Design();
        WriteCode();
        Test();
        Deploy();
    }
    
    protected abstract void Analysis();
    protected abstract void Design();
    protected abstract void WriteCode();
    protected abstract void Test();
    protected abstract void Deploy();
}