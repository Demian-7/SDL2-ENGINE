namespace MyGame.Scripts.UI
{
    /// <summary>
    /// Abstract class of UIElements. It contain the essential attributes for game UI elements.
    /// </summary>
    public abstract class UIElements
    {
        public int posX;
        public int posY;
        public int width;
        public int height;

        /// <summary>
        /// Abstract update of the UIElements. It is requiered in every class that inherits of this class. All the elements that need to be updated during runtime will go here.
        /// </summary>
        public abstract void Update();

        /// <summary>
        /// Abstract render of the UIElements. It is requiered in every class that inherits of this class. All the elements that need to be rendered during runtime will go here.
        /// </summary>
        public abstract void Render();
    }
}
