using Godot;
using System;

public class Player : KinematicBody2D
{

    Vector2 direction;
    float movementSpeed = 500;
    float gravity = 90;
    float maxFallSpeed = 1000;
    float minFallSpeed = 5;

    float jumpForce = 1000;

    Sprite sprite;
    AnimationPlayer animationPlayer;
    public override void _Ready()
    {
        sprite = (Sprite)GetNode("Sprite");
        animationPlayer = (AnimationPlayer)GetNode("AnimationPlayer");
    }


    public override void _PhysicsProcess(float delta)
    {
        //player gravity
        direction.y += gravity;
        if(direction.y > maxFallSpeed)
        {
            direction.y = maxFallSpeed;
        }

        if(IsOnFloor())
        {
            direction.y = minFallSpeed; 
        }

        //player movement
        direction.x = Input.GetActionStrength("move_right") -Input.GetActionStrength("move_left");
        direction.x *= movementSpeed;

        //player jump
        if(IsOnFloor() && Input.IsActionJustPressed("jump"))
        {
            direction.y = -jumpForce;
        }

        //sprite flip
        if(direction.x > 0)
        {
            sprite.FlipH =  false;
        }

        else if (direction.x < 0)
        {
            sprite.FlipH = true;
        }

        direction =  MoveAndSlide(direction, Vector2.Up);
    }

}
