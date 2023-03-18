

namespace OldRobot; 

public interface IRobotCommand {
	void Run(Robot robot);
}


public class OnCommand : IRobotCommand {
	//public override void Run(Robot robot) {
	//	throw new NotImplementedException();
	//}
	void IRobotCommand.Run(Robot robot) {
		robot.IsPowered = true;
	}
}


public class OffCommand : IRobotCommand {
	void IRobotCommand.Run(OldRobot.Robot robot) {
		robot.IsPowered = false;
	}
}


public class NorthCommand : IRobotCommand {
	void IRobotCommand.Run(OldRobot.Robot robot) {
		if (robot.IsPowered) robot.Y += 1;
	}

}
	
	
public class SouthCommand : IRobotCommand {
	void IRobotCommand.Run(OldRobot.Robot robot) {
		if (robot.IsPowered) robot.Y -= 1;
	}
}


public class WestCommand : IRobotCommand {
	void IRobotCommand.Run(Robot robot) {
		if (robot.IsPowered) robot.X -= 1;
	}
}


public class EastCommand : IRobotCommand {
	void IRobotCommand.Run(Robot robot) {
		if (robot.IsPowered) robot.X += 1;
	}
}


