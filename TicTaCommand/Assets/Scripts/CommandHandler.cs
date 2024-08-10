using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractAction
{
    protected readonly TurnHandler turnHandlerAsCommand;

    public int index;

    protected AbstractAction(TurnHandler inputedTurnHandler)
    {
        turnHandlerAsCommand = inputedTurnHandler;
    }

    public void Execute()
    {

    }

   
}


public class PassTurnCommand :AbstractAction
{
    public readonly int buttonIndex;
    public PassTurnCommand(TurnHandler _turnhandler, int index) : base(_turnhandler)
    {
        buttonIndex = index;
    }
    public void Execute()
    {
        turnHandlerAsCommand.PlayAndPassTurn(buttonIndex);
    }




}

public class UndoCommand : AbstractAction
{
    public readonly int buttonIndex;
    public UndoCommand(TurnHandler _turnhandler, int index) : base(_turnhandler)
    {
        buttonIndex = index;
    }
    public void Execute()
    {
        turnHandlerAsCommand.TurnUndo(buttonIndex);
    }




}
public class RedoCommand : AbstractAction
{
    public readonly int buttonIndex;
    public RedoCommand(TurnHandler _turnhandler, int index) : base(_turnhandler)
    {
        buttonIndex = index;
    }
    public void Execute()
    {
        turnHandlerAsCommand.TurnUndo(buttonIndex);
    }




}


public class CommandHandler : MonoBehaviour
{
    public AbstractAction actionToExecute;
    public TurnHandler _turnHandler;

    private Stack<int> recordsContaier;
    private Stack<int> optionalRedoContainer;


    private void Start()
    {
        recordsContaier = new Stack<int>();
        optionalRedoContainer = new Stack<int>();
    }

    public void Record(int actionNum)
    {
        recordsContaier.Push(actionNum);
        // action.Execute();
    }
    

    public void PlayRegularTurn(int index)
    {
        Debug.Log(index);
        AbstractAction action = new PassTurnCommand(_turnHandler, index);
        Record(index);
        action.Execute();
    }

    public void PlayUndoTurn()
    {
        int index = recordsContaier.Pop();

        AbstractAction action = new UndoCommand(_turnHandler, index);
        optionalRedoContainer.Push(index);
        action.Execute();
    }




    //public void Rewind()
    //{
    //    var action = recordsContaier.Pop();
    //    action.Undo();
    //}
}
