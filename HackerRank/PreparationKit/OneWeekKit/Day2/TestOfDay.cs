namespace HackerRank.PreparationKit.OneWeekKit.Day2;
public class TestOfDay
{
    public static int FlipMatrix(List<List<int>> matrix)
    {
        var sortedMatrix = new List<List<int>>();

        foreach (var item in matrix)
        {
            sortedMatrix.Add(item.OrderByDescending(i => i).ToList());
        }

        var firstColumn = new List<int>();
        var secondColumn = new List<int>();

        foreach (var item in sortedMatrix)
        {
            firstColumn.Add(item[0]);
            secondColumn.Add(item[1]);
        }

        firstColumn = firstColumn.OrderByDescending(i => i).ToList();
        secondColumn = secondColumn.OrderByDescending(i => i).ToList();

        var result = firstColumn[0] + firstColumn[1] + secondColumn[0] + secondColumn[1];
        return result;
    }
}
