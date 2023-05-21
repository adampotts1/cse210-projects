public class Checklist : Goal
{

    public override void Display()
    {
        setGoalName();
        setGoalDescription();
        setGoalPoints();
        setGoalRepeat();
        setRepeatPoints();
    }

    public override string GetStringRepresentation()
    {
        return $"{getGoalType()}:{GetGoalName()},{GetGoalDescription()},{GetGoalPoints()},{GetRepeatBonus()},{GetRepeatPoints()},{getcompletedRepeat()}";
    }

}