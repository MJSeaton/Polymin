# Polymin

Polymin is the working title for the development branch of Harmony Space, winning entry to MIT's Hacking Arts 2016 Hackathon.
It is an Augmented Reality App created in Unity using C# intended to be used on Microsoft's Hololens platform. It allows you to use your
eyes, ears, and sense of self in space together to understand the fundamentals of music theory- how notes relate to one another. It does
this by mapping your position in the 3 spatial dimensions X, Y, and z to the pitch of 3 distinct independent tones. Moving in each of these
dimensions will affect the associated tone. It also creates markers at the locations of chords in space, allowing you to physically navigate
the world of sound.

Though it has not been tested on other platforms, in theory it should be possible to run on other SLAM capable AR devices that Unity can 
create executables for.

Currently, Harmony Space loads note data from a tuning file (*/Assets/StreamingAssets/notes.json). Since chord locations are created 
dynamically at runtime, it is possible to change the tuning of Harmony Space (for example, to explore the space where A is 432Hz as 
opposed to 440Hz.) The tuning and programatic creation of objects occurs in the DataManager.cs script- chords can be created by
calling the "PlaceInSpace" function and passing in note name and octave information in the form detailed in the notes.json file [ex-PlaceInSpace("A1", "D#0", "C3")] 

The next feature push is set to include increased user interactivity, chord information populating the UI, creation of chords based on a chords.json file,
and limited voice control.
