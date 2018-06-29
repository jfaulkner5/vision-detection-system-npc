using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace visionsystem
{
    public class VisionCheck
    {
        //the distance that the entity can see other entities
        private int spotDistance;
        private int currentDistance;
        //field of view of the entity
        private int fieldOfView;
        private GameObject player;
        //setup basic data
        void SetupVisionData(int _spotDistance, int _fieldOfView, GameObject _player)
        {
            spotDistance = _spotDistance;
            fieldOfView = _fieldOfView;
            player = _player;
        }

        bool IsInSight(GameObject entityPosition)
        {
            currentDistance = (int)Vector3.Distance(entityPosition.transform.position, player.transform.position);
            Vector3 fwdDir = entityPosition.transform.forward;
            float tempangle = Vector3.Angle(fwdDir, player.transform.position);
            if (tempangle <= (fieldOfView / 2) && currentDistance <= spotDistance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
