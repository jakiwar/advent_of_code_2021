using Plots
# open("testinput.txt") do f
open("input.txt") do f
        matr = zeros(Int, 10,10)
        linecounter = 1
        for ln in eachline(f)
            lnCol = collect(ln)
            linevec = zeros(Int, 1,10)
            for index in eachindex(lnCol)
                linevec[index] = parse(Int, lnCol[index])
            end
    
            
            # println(linevec)
            matr[linecounter, :]=  linevec
            linecounter +=1
        end
        # println(size(matr))
        # println(matr)
    
        dirs = [1,-1,0]
        flashCounter = 0
        answerPart1 = 0
        answerPart2 = 0
        matrixRange = 1:1:10
        neighbourAdd = [-1,1,0]
        
        # for i in matrixRange
        #     println(matr[i,:])
        # end

        
        
        
        iters = 1:1:10000
        gr()
        
        anim = @animate for iter in iters
            #plotting
            # data = rand(21,100)
            iterString = string("Step=", iter)
            # println(iterString)
            plt = heatmap(1:size(matr,1),
                1:size(matr,2), matr,
                c=:thermal,#cgrad([:blue, :red, :yellow, :white]),
                clims = (0,10),
                xlims = (0,10),
                ylims = (0,10),
                ticks = false,
                xlabel=" ",
                ylabel =" ",  
                annotations = ([0.3], [-0.5], string("Step=", iter)),
                # ylabel="y values",
                title="Advent of Code 11 dec 2021"
                )
            # png(plt, "aoc_11.png")

            #end plot
            
            flashWhile = true
            matr = matr.+1 #increase 1
            
            while(flashWhile)
                lastFlashCounter = flashCounter
                for n in matrixRange
                    for m in matrixRange
                        elm = matr[n,m]
                        if elm > 9 #flash
                            flashCounter +=1
                            matr[n,m] = 0

                            for i in neighbourAdd
                                for j in neighbourAdd
                                    nn = n + i
                                    mm = m + j
                                    if nn in matrixRange && mm in matrixRange
                                        if matr[nn,mm] != 0 #flash only once
                                            matr[nn,mm] +=1
                                        end
                                    end
                                end
                            end
                        end
                    end
                end
                if lastFlashCounter == flashCounter
                    flashWhile = false
                end
            end

            if iter == 100
                answerPart1 = flashCounter
            end

            matrSum = sum(matr)
            if matrSum == 0
                answerPart2 = iter
                break;
            end

            # println("Iter ", iter)
            # for i in matrixRange
            #     println(matr[i,:])
            # end
        end
        println("flashCounter (answer part 1 ): ", answerPart1)
        println("simulIter (answer part 2 ): ", answerPart2)
        gif(anim, "aoc_11_progress.gif", fps = 20)
    end
