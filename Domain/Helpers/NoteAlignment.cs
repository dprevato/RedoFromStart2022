using JetBrains.Annotations;

namespace Domain.Helpers
{
    [UsedImplicitly]
    public enum NoteAlignment : int
    {
        UpperLeft,
        UpperRight,
        UpperCenter,
        MiddleLeft,
        MiddleCenter,
        MiddleRight,
        LowerLeft,
        LowerRight,
        LowerCenter
    }
}