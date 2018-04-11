using UnityEngine;
using System.Collections;

/// <summary>
/// Top step platform, this script should be attached to the top step of a ladder.
/// </summary>
public class TopStepPlatform2D : LadderCollider2D {

	private bool actAsGround = true;

	override public bool overrideX {
		get { return !actAsGround;}
	}

	override public Transform ParentOnStand(RaycastCharacterController2D character) {
		if ((character.StartedClimbing || character.characterInput.y < 0.0f)) actAsGround = false;
		else actAsGround = true;
		return transform;
	}


}