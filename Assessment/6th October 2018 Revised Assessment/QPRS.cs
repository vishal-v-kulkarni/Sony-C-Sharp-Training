using System;

interface Target{

	int getTarget(); 
}

public class Employees{
	public String Name;
	public int GID;

	public String evaluateGrade(int percent){
		if(percent >= 80 && percent <= 100){
			return "is Outstanding";
		}else if(percent >= 70 && percent < 80){
			return "is Excellent";
		}else if(percent >= 60 && percent < 70){
			return "is Wonderful";
		}else if(percent >= 50 && percent < 60){
			return "is Good";
		}else{
			return "has Scope for improvement";
		}

	}

}

public class TechnicalTeam : Employees,Target{
	private int targetBillAmt=0;
	public int billAmt=0;
	public int techNum=0;
	public int certNum=0;

	public void setTarget(int targetBillAmt){
		this.targetBillAmt = targetBillAmt;
	}
	public int getTarget(){
		return targetBillAmt;
	}

}

public class MarketingTeam : Employees,Target{

	private int targetBusVolume=0;
	public int busVolume=0;

	public void setTarget(int targetBusVolume){
		this.targetBusVolume = targetBusVolume;
	}
	public int getTarget(){
		return targetBusVolume;
	}

}

public class MainClass{
		
		public int tPercent;
		public int mPercent;
		public static int totalTPer;
		public static int totalMPer;
	

	public static void Main(){

		

		MainClass mc = new MainClass();

		TechnicalTeam techManager = new TechnicalTeam();
		MarketingTeam marketManager = new MarketingTeam();

		//Technical Manager sets the target
		techManager.setTarget(3000);

		//Marketing Manager sets the target
		marketManager.setTarget(50);

		login:

		Console.WriteLine("******************************LOGIN PORTAL***********************************");
		Console.WriteLine("Enter the name : ");
		String name = Console.ReadLine();
		Console.WriteLine("Enter the password : ");
		String password = Console.ReadLine();

		if(mc.authenticate(name,password)){

			TechnicalTeam tt = new TechnicalTeam();
			MarketingTeam mt = new MarketingTeam();

			Console.WriteLine("Enter the details of the Technical Employee to Review");
			Console.Write("Enter the name :");
			Console.WriteLine();
			tt.Name = Console.ReadLine();
			Console.Write("Enter the GID :");
			tt.GID = Int32.Parse(Console.ReadLine());

			for( int iCounter=0;iCounter<3;iCounter++){
				
				Console.WriteLine("Enter the performance details of the Technical Employee to Review");
				Console.WriteLine();
				Console.Write("Enter the Bill Amount : ");
				tt.billAmt = Int32.Parse(Console.ReadLine());
				Console.WriteLine();
				tech:
				Console.WriteLine("Enter the number of technology upgrages :");
				tt.techNum = Int32.Parse(Console.ReadLine());
				if(tt.techNum > 3){
					Console.WriteLine("Cannot have upgrades more than 3");
					goto tech;
				}
				cert:
				Console.WriteLine("Enter the number of certificates : ");
				tt.certNum = Int32.Parse(Console.ReadLine());
				if(tt.certNum > 1){
					Console.WriteLine("Cannot have certtificates more than 1");
					goto cert;
				}

				Console.WriteLine();

				mc.evaluateTechPer(tt,techManager);

			}

			Console.WriteLine("Enter the details of the Marketing Employee to Review");
			Console.Write("Enter the name : ");
			mt.Name = Console.ReadLine();
			Console.WriteLine();
			Console.Write("Enter the GID : ");
			mt.GID = Int32.Parse(Console.ReadLine());

			for(int iCounter=0;iCounter<3;iCounter++){

				Console.WriteLine("Enter the performance details of the Marketing Employee to Review");
				Console.WriteLine();
				Console.WriteLine("Enter the Business Volume : ");
				mt.busVolume = Int32.Parse(Console.ReadLine());
				Console.WriteLine();

				mc.evaluateMarkPer(mt,marketManager);

			}

			Console.WriteLine("Technical Team : The Average of the {0} for 3 Months is {1}",tt.Name,totalTPer/3);
			
			Console.WriteLine("Marketing Team : The Average of the {0} for 3 Months is {1}",mt.Name,totalMPer/3);


		}else{
			Console.WriteLine("Invalid User..!!");
			goto login;
		}
		
	}

	public void evaluateMarkPer(MarketingTeam mt,MarketingTeam mt1){
		if(mt.busVolume > mt1.getTarget()){
			mPercent = 100;
		}else{
			double dNum = mt.busVolume/mt1.getTarget();
			mPercent = Convert.ToInt32(dNum * 100);
		}

		totalMPer = totalMPer + mPercent;

		Console.WriteLine("The employee {0} of Marketing Team {1}" ,mt.Name,mt.evaluateGrade(mPercent));

	}

	public void evaluateTechPer(TechnicalTeam tt,TechnicalTeam tt1){

		double dNum = tt.billAmt/tt1.getTarget();
		int iNum = Convert.ToInt32(dNum*100);

		int iNum4 = Convert.ToInt32(iNum*0.6);

		int iNum2 = tt.techNum*10;
		int iNum3 = tt.certNum*10;

		int tPercent = iNum2+iNum3+iNum4;

		totalTPer = totalTPer + tPercent;

		Console.WriteLine("The employee {0} of Technical Team {1}" ,tt.Name,tt.evaluateGrade(mPercent));

	}

	public bool authenticate(String name , String password){
	
		if(name == "Vishal" && password == "vishal1508"){
			return true;
		}
		
		return false;

	}
}