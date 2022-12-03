using UnityEngine;
using System;
using System.Collections.Generic;

namespace GorillaLocomotion
{
	public class Player : MonoBehaviour
	{
		[Serializable]
		public struct MaterialData
		{
			public string matName;
			public bool overrideAudio;
			public AudioClip audio;
			public bool overrideSlidePercent;
			public float slidePercent;
		}

		public SphereCollider headCollider;
		public CapsuleCollider bodyCollider;
		public Transform leftHandFollower;
		public Transform rightHandFollower;
		public Transform rightHandTransform;
		public Transform leftHandTransform;
		public Vector3 lastHeadPosition;
		public int velocityHistorySize;
		public float maxArmLength;
		public float unStickDistance;
		public float velocityLimit;
		public float maxJumpSpeed;
		public float jumpMultiplier;
		public float minimumRaycastDistance;
		public float defaultSlideFactor;
		public float defaultPrecision;
		public float teleportThresholdNoVel;
		public Vector3 rightHandOffset;
		public Vector3 leftHandOffset;
		public Vector3 bodyOffset;
		public LayerMask locomotionEnabledLayers;
		public bool wasLeftHandTouching;
		public bool wasRightHandTouching;
		public int currentMaterialIndex;
		public bool disableMovement;
		public bool inOverlay;
		public bool didATurn;
		public GameObject turnParent;
		public int leftHandMaterialTouchIndex;
		public GorillaSurfaceOverride leftHandSurfaceOverride;
		public int rightHandMaterialTouchIndex;
		public GorillaSurfaceOverride rightHandSurfaceOverride;
		public GorillaSurfaceOverride currentOverride;
		public List<Player.MaterialData> materialData;
	}
}
