// Zach Holcomb, Bryce Woodland, Luke Briggs

House cribbb = new House();

Room goonroom = new Room();
cribbb.AddRoom(goonroom);

SmartDevice light1 = new SmartDevice(true, "light1", "Light");
SmartDevice light2 = new SmartDevice(true, "light2", "Light");

//google turn on the goon room lights

goonroom.setDevice(light1);
goonroom.setDevice(light2);

goonroom.getDevices();
goonroom.turnOnlights();
goonroom.getDevices();



// Reflection reflection = new Reflection();
// reflection.StartActivity();
