namespace Battle_Ships
{
    //Type of value A cell currently is

    public enum MarkType
    {
        //The cell wasn't clicked
        Free,

        //The cell = Occupied by ship
        OccupiedByShip,

        //The cell = Miss
        Miss,

        //The Hit
        Hit
    }
}
