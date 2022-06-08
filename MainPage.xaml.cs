namespace Aligment;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	void OnHorizontalStartClicked(object sender, EventArgs e) 
    { 
        target.HorizontalOptions = LayoutOptions.Start;
        horizontalAligmentLabel.Text = "Start";
    }
    void OnHorizontalCenterClicked(object sender, EventArgs e) 
    { 
        target.HorizontalOptions = LayoutOptions.Center;
        horizontalAligmentLabel.Text = "Center";
    }
    void OnHorizontalEndClicked(object sender, EventArgs e) 
    { 
        target.HorizontalOptions = LayoutOptions.End;
        horizontalAligmentLabel.Text = " End";
    }
    void OnHorizontalFillClicked(object sender, EventArgs e) 
    { 
        target.HorizontalOptions = LayoutOptions.Fill;
        horizontalAligmentLabel.Text = " Fill";
    }

    void OnVerticalStartClicked(object sender, EventArgs e) 
    { 
        target.VerticalOptions = LayoutOptions.Start;
        verticalAligmentLabel.Text = " Start";
    }
    void OnVerticalCenterClicked(object sender, EventArgs e) 
    { 
        target.VerticalOptions = LayoutOptions.Center;
        verticalAligmentLabel.Text = " Center";
    }
    void OnVerticalEndClicked(object sender, EventArgs e) 
    { 
        target.VerticalOptions = LayoutOptions.End;
        verticalAligmentLabel.Text = " End";
    }
    void OnVerticalFillClicked(object sender, EventArgs e) 
    { 
        target.VerticalOptions = LayoutOptions.Fill;
        verticalAligmentLabel.Text = " Fill";
    }
}

