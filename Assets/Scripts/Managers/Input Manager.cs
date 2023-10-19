using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager 
{
    private static Controls _controls; 
    
    public static void Initialize(Player myPlayer)
    {
        _controls = new Controls();

        _controls.Perm.Enable(); 

        _controls.Game.Move.performed += ctx =>
        {
            myPlayer.SetMovementDirection(ctx.ReadValue<Vector2>());
        }; 
    }

    public static void Gamemode()
    {
        _controls.Game.Enable();
        _controls.UI.Disable(); 
    }

    public static void UImode()
    {
        _controls.Game.Disable();
        _controls.UI.Enable(); 
    }

}
