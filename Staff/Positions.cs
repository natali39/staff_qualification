using System.ComponentModel;

namespace staff_qualification_Forms
{
    public enum Positions
    {
        [Description("Швея")]
        Seamstress = 0,

        [Description("Контролёр")]
        Control = 1,

        [Description("Мастер")]
        Master = 2,

        [Description("Начальник производства")]
        ProductionManager = 3,
    }
}
