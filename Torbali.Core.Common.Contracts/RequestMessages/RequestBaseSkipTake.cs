namespace Torbali.Core.Common.Contracts.RequestMessages
{
    public abstract  class RequestBaseSkipTake
    {
        int Take { get; set; }
        int Skip { get; set; }
    }
}
