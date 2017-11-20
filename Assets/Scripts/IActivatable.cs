//monobehavior allows it to be dragged onto gameobjects
public interface IActivatable {
    //you can call this function on any activatable object. 
    //The switch has an activate function, and so does the door and the collectable
    void DoActivate();
}
