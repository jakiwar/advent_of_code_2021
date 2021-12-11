using Plots
x = 1:10; y = rand(10); # These are the plotting data 
plt = plot(x,y, label="my label")
png(plt, "plt.png")