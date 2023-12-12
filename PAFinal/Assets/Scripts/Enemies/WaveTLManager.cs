using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class WaveTLManager : MonoBehaviour
{
    private PlayableDirector timeLine;
    [SerializeField] private List<TimelineAsset> timelineAssetList;
    [SerializeField] private List<TimeLineObjects> timelineObjects;

    private void Start()
    {
        AwakeMetod();
    }

    private void AwakeMetod()
    {
        timeLine = GetComponent<PlayableDirector>();
        timeLine.playableAsset = timelineAssetList[GameManager.SharedInstance.levelToCharge -1];
        foreach (TimeLineObjects timelineObject in timelineObjects )
        {
            SearchTimeLineTrack(timelineObject.gameObjectName, timelineObject.referencedGO);
        }
        PlayTimeLine();
    }

    public void PauseTimeLine()
    {
        timeLine.Pause();
    }

    public void PlayTimeLine()
    {
        timeLine.Play();
    }

    private void SearchTimeLineTrack(string track, GameObject reference)
    {
        foreach (var playableAssetOutput in timeLine.playableAsset.outputs)
        {
            if(playableAssetOutput.streamName == track)
            {
                timeLine.SetGenericBinding(playableAssetOutput.sourceObject, reference);
            }
        }
    }
}
