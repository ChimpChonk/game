using Godot;
using System;

public class coin : Area2D
{

    Player player = new Player();
    AnimationPlayer animationPlayer;
    //int coins = 0;

    [Signal]
    public delegate void coin_collected(string coin);
    public override void _Ready()
    {
        animationPlayer = (AnimationPlayer)GetNode("AnimationPlayer");
        EmitSignal(nameof (coin_collected));

    }
    public void _on_coin_body_entered(Node body)
    {
        animationPlayer.Play("coin_bounce");
        player.coins = player.coins + 2;
        GD.Print(player.coins);


    }

    

    private void _on_AnimationPlayer_animation_finished(AnimationPlayer animation)
    {
        QueueFree();
    }

    
}
