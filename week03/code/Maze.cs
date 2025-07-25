/// <summary>
/// Defines a maze using a dictionary. The dictionary is provided by the
/// user when the Maze object is created. The dictionary will contain the
/// following mapping:
///
/// (x,y) : [left, right, up, down]
///
/// 'x' and 'y' are integers and represents locations in the maze.
/// 'left', 'right', 'up', and 'down' are boolean are represent valid directions
///
/// If a direction is false, then we can assume there is a wall in that direction.
/// If a direction is true, then we can proceed.
///
/// If there is a wall, then throw an InvalidOperationException with the message "Can't go that way!".  If there is no wall,
/// then the 'currX' and 'currY' values should be changed.
/// </summary>
public class Maze
{
    private const int LeftMoveAllowedIdx = 0;
    private const int RightMoveAllowedIdx = 1;
    private const int UpMoveAllowedIdx = 2;
    private const int DownMoveAllowedIdx = 3;
    private readonly Dictionary<ValueTuple<int, int>, bool[]> _mazeMap;
    private int _currX = 1;
    private int _currY = 1;

    private ValueTuple<int, int> currPosKey()
    {
        return (_currX, _currY);
    }

    private ValueTuple<int, int> rightMoveKey()
    {
        return (_currX + 1, _currY);
    }

    private ValueTuple<int, int> leftMoveKey()
    {
        return (_currX - 1, _currY);
    }

    private ValueTuple<int, int> downMoveKey()
    {
        return (_currX, _currY + 1);
    }

    private ValueTuple<int, int> upMoveKey()
    {
        return (_currX, _currY - 1);
    }

    public Maze(Dictionary<ValueTuple<int, int>, bool[]> mazeMap)
    {
        _mazeMap = mazeMap;
    }

    // TODO Problem 4 - ADD YOUR CODE HERE
    /// <summary>
    /// Check to see if you can move left.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveLeft()
    {
        if (_mazeMap.Keys.Contains(leftMoveKey()) && _mazeMap[currPosKey()][LeftMoveAllowedIdx])
            _currX--;
        else
            throw new InvalidOperationException("Can't go that way!");
    }

    /// <summary>
    /// Check to see if you can move right.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveRight()
    {
        if (_mazeMap.Keys.Contains(rightMoveKey()) && _mazeMap[currPosKey()][RightMoveAllowedIdx])
            _currX++;
        else
            throw new InvalidOperationException("Can't go that way!");
    }

    /// <summary>
    /// Check to see if you can move up.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveUp()
    {
        if (_mazeMap.Keys.Contains(upMoveKey()) && _mazeMap[currPosKey()][UpMoveAllowedIdx])
            _currY--;
        else
            throw new InvalidOperationException("Can't go that way!");
    }

    /// <summary>
    /// Check to see if you can move down.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveDown()
    {
        if (_mazeMap.Keys.Contains(downMoveKey()) && _mazeMap[currPosKey()][DownMoveAllowedIdx])
            _currY++;
        else
            throw new InvalidOperationException("Can't go that way!");
    }

    public string GetStatus()
    {
        return $"Current location (x={_currX}, y={_currY})";
    }
}
