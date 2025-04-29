namespace MyGame.Scripts.Managers
{
    public enum ProgramState
    {
        MAINMENU,
        GAME,
        RESULTS
    }
    public class SceneManager
    {
        public ProgramState currentProgramState { get; private set; } = ProgramState.MAINMENU;
        public void LoadScene(ProgramState state)
        {
            currentProgramState = state;
        }
    }
}