private void OnGrab(object sender, InteractableObjectEventArgs e)
    {
        //throw new System.NotImplementedException();
        Debug.Log("Grabbed");

        while (TriggerPressed) // Needs to called in Update()
        {
            Vector3 dist = controllerLeft.transform.position - controllerLeft.transform.position;
            float scaleIntermediate = dist.magnitude; //actual distance in Unity meters between zero and somewhere between .5 and 1
            public fudgeFactor = 2; //move to the top the script, we expose this to control 
            scaleFactor *= fudgeFactor * scaleIntermediate; // multiply existing public scaleFactor against distance btwn controller modified by a fudgefactor
            transform.localScale += new Vector3(scaleFactor, scaleFactor, scaleFactor);
           
        } 

        if (triggerReleased) {

            startThrowingSequence = true;

        }

        //e.interactingObject...
    }
