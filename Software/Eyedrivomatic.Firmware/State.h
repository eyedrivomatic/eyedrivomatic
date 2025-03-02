//	Copyright (c) 2018 Eyedrivomatic Authors
//	
//	This file is part of the 'Eyedrivomatic' PC application.
//	
//	This program is intended for use as part of the 'Eyedrivomatic System' for 
//	controlling an electric wheelchair using soley the user's eyes. 
//	
//	Eyedrivomaticis distributed in the hope that it will be useful,
//	but WITHOUT ANY WARRANTY; without even the implied warranty of
//	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  


// State.h

#ifndef _STATE_h
#define _STATE_h

#if defined(ARDUINO) && ARDUINO >= 100
	#include "arduino.h"
	#include <Servo.h>
#else
	#include "WProgram.h"
#endif

enum HardwareSwitch { Switch1, Switch2, Switch3 };

const char SwitchName_1[] PROGMEM = "SWITCH 1";
const char SwitchName_2[] PROGMEM = "SWITCH 2";
const char SwitchName_3[] PROGMEM = "SWITCH 3";
const char * const HardwareSwitchNames[] = { SwitchName_1, SwitchName_2, SwitchName_3 };

const char OnString[] PROGMEM = "ON";
const char OffString[] PROGMEM = "OFF";

class StateClass
{
public:
	void init();
	void reset();

	void getServoPositions(float & xPos, float & yPos);
	void getServoPositionsRelative(int8_t & xPos, int8_t & yPos);

	void setServoPositions(int8_t xPos, int8_t yPos);
	void setServoPositionsRelative(int8_t xPos, int8_t yPos);

	void resetServoPositions();

	bool getSwitchState(HardwareSwitch hardwareSwitch);
	void setSwitchState(HardwareSwitch hardwareSwitch, bool state);

	size_t toString(char * buffer, size_t size);

private:
	Servo xServo;  // servo object to control the x servo
	Servo yServo;  // servo object to control the y servo
};

extern StateClass State;

#endif

